using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeltExam2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace BeltExam2.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [Route("register")]
        [HttpPost]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)//if no validation error, do the following
            {
                if (dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    System.Console.WriteLine("////////////email already in use//////////");
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");//Consider returning to View at this point
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Add(newUser);
                    dbContext.SaveChanges();

                    HttpContext.Session.SetString("Session", "True");
                    HttpContext.Session.SetString("FirstName", newUser.FirstName);
                    HttpContext.Session.SetString("LastName", newUser.LastName);
                    HttpContext.Session.SetInt32("UserID", newUser.UserID);

                    return RedirectToAction("Dashboard");
                }
            }
            else//if validator errored, then go back to the below page and show validation
            {
                return View("Index");
            }
        }

        [Route("login")] ///////////////RENDER LOGIN///////////////
        [HttpPost]
        public IActionResult Login(Login thisUser)
        {
            if (ModelState.IsValid)
            {
                System.Console.WriteLine("//////////////SUCCESS///////////////////");

                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == thisUser.LoginEmail);

                if (userInDb == null)// If no user exists with provided emailcopy
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Index");
                }
                // Initialize hasher object
                var hasher = new PasswordHasher<Login>();

                // varify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(thisUser, userInDb.Password, thisUser.LoginPassword);

                // result can be compared to 0 for failure
                if (result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Invalid Password");
                    return View("Index");
                }

                HttpContext.Session.SetString("Session", "True");
                HttpContext.Session.SetString("FirstName", userInDb.FirstName);
                HttpContext.Session.SetString("LastName", userInDb.LastName);
                HttpContext.Session.SetInt32("UserID", userInDb.UserID);

                return RedirectToAction("Dashboard");
            }
            else
            {
                System.Console.WriteLine("***************FAIL VALIDATION**********************");
                return View("Index");
            }
        }
        //////////////////////////////Login and Registration End////////////////////////////////////
        [Route("Dashboard")]/////////////RENDER DASHBOARD HERE//////////////////////////
        [HttpGet]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("Session") == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                List<Activityclass> AllAct = dbContext.Activities
                .Include(x => x.ActivityToUser)
                .ThenInclude(p => p.Users)
                .OrderByDescending(f => f.ActivityID)
                .ToList();

                AllAct.Reverse();

                ViewBag.allactivities = AllAct;


                // var actstousers = dbContext.Activities
                // .Include(x=>x.ActivityToUser)
                // .ThenInclude(x => x.Users)
                // .FirstOrDefault(x => x.ActivityID == HttpContext.Session.GetInt32("activityid"));
                // ViewBag.actstousers = actstousers;




                // Activityclass theActivity = dbContext.Activities.Include(a => a.ActivityToUser).ThenInclude(p => p.Users).SingleOrDefault(a => a.ActivityID == actid);
                // ViewBag.acttouser = theActivity;

                ViewBag.sessionid = HttpContext.Session.GetInt32("UserID");

                ViewBag.firstname = HttpContext.Session.GetString("FirstName");
                return View("Dashboard");
            }
        }

        [Route("NewActivity")]/////////////RENDER NEW ACTIVTY PAGE  HERE//////////////////////////
        [HttpGet]
        public IActionResult NewActivity()
        {
            if (HttpContext.Session.GetString("Session") == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                String clock = DateTime.Now.ToString("yyyy-MM-dd");
                ViewBag.datetime = clock;

                ViewBag.sessionid = HttpContext.Session.GetInt32("UserID");

                return View("NewActivity");
            }
        }

        [Route("CreateActivity")]
        [HttpPost]
        public IActionResult CreateActivity(Activityclass newActivity)
        {
            if (Request.Form["dur"] == "minutes")
            {
                newActivity.Duration = newActivity.Duration;
            }
            if (Request.Form["dur"] == "hours")
            {
                newActivity.Duration = newActivity.Duration * 60;
            }
            if (Request.Form["dur"] == "days")
            {
                newActivity.Duration = newActivity.Duration * 1440;
            }

            if (ModelState.IsValid)
            {
                newActivity.CreatedAt = DateTime.Now;
                newActivity.UpdatedAt = DateTime.Now;
                dbContext.Add(newActivity);
                dbContext.SaveChanges();

                System.Console.WriteLine("*****************Activity successfully added*******************");

                return RedirectToAction("ActivityInfo", new { actid = newActivity.ActivityID });
            }
            else
            {
                System.Console.WriteLine("**********FAIL VALIDATION*********");
                return View("NewActivity");
            }

        }

        [Route("activity/{actid}")]/////////////ACTIVITY INFO PAGE//////////////////////////
        [HttpGet]
        public IActionResult ActivityInfo(int actid)
        {
            if (HttpContext.Session.GetString("Session") == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Activityclass ThisAct = dbContext.Activities.FirstOrDefault(x => x.ActivityID == actid);
                ViewBag.thisactivity = ThisAct;

                Activityclass theActivity = dbContext.Activities.Include(a => a.ActivityToUser).ThenInclude(p => p.Users).SingleOrDefault(a => a.ActivityID == actid);
                ViewBag.acttouser = theActivity;

                int num = theActivity.UserID;
                ViewBag.theuser = dbContext.Users.SingleOrDefault(u => u.UserID == num);

                var actstousers = dbContext.Activities
                .Include(x => x.ActivityToUser)
                .ThenInclude(x => x.Users)
                .SingleOrDefault(a => a.ActivityID == actid);

                return View("Activityinfo");
            }
        }

        [Route("join/{actid}/{userid}")]
        [HttpGet]
        public IActionResult Join(int actid, int userid)
        {
            Activityclass newAct = dbContext.Activities.Include(c => c.ActivityToUser).ThenInclude(b => b.Users).FirstOrDefault(wed => wed.ActivityID == actid);
            User newUser = dbContext.Users.Include(c => c.ParticipatingActivities).ThenInclude(b => b.Activitys).FirstOrDefault(us => us.UserID == userid);
            foreach (var thisact in newUser.ParticipatingActivities)
            {
                if (thisact.Activitys.Date.Date == newAct.Date.Date)
                {
                    ModelState.AddModelError("ActDate", "Conflicting date!!!");
                    ViewBag.samedayrs = "You have plan to go to another activity on that day already!!!";
                    return RedirectToAction("Dashboard");
                }
            }

            Participate assjoin = new Participate();
            assjoin.ActivityID = actid;
            assjoin.UserID = userid;
            dbContext.Add(assjoin);
            dbContext.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        [Route("leave/{partid}")]
        [HttpGet]
        public IActionResult UNRSVP(int partid)
        {
            Participate thisPartID = dbContext.Participations.FirstOrDefault(x => x.ParticipateID == partid);
            dbContext.Participations.Remove(thisPartID);
            dbContext.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        [Route("delete/{id}")] ////DELETE BUTTON
        [HttpGet]
        public IActionResult Delete(int id)
        {

            Activityclass ThisAct = dbContext.Activities.FirstOrDefault(x => x.ActivityID == id);
            dbContext.Activities.Remove(ThisAct);
            dbContext.SaveChanges();

            return RedirectToAction("Dashboard");

        }

    }
}


