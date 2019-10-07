﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using santisart_app.Models;

namespace santisart_app.Controllers
{
    public class UserProfilesController : Controller
    {
<<<<<<< HEAD
        private santisartEntities2 db = new santisartEntities2();
=======
        private backupServerEntities1 db = new backupServerEntities1();
>>>>>>> 81fd92b2750a4cd9bd85dec9ed1efdf1a5981156

        // GET: UserProfiles
        public ActionResult Index()
        {
            return View(db.UserProfiles.ToList());
        }
        public ActionResult Login(string ReturnUrl)
        {
            
            Session["PageUrl"] = ReturnUrl;
            //Response.Redirect("~/login.aspx?ReturnURL=" + returnUrl);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserProfile objUser)
        {
            if (ModelState.IsValid)
            {
<<<<<<< HEAD
                using (santisartEntities2 db2 = new santisartEntities2())
=======
                using (backupServerEntities1 db2 = new backupServerEntities1())
>>>>>>> 81fd92b2750a4cd9bd85dec9ed1efdf1a5981156
                {
                    var obj = db2.Employees.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.EmpId.ToString();
                        Session["UserName"] = obj.UserName.ToString();
                       Session["Room"] = db.Enroll_RoomSession_Emp.Where(x => x.userid == obj.EmpId).Include(e=>e.RoomSession).ToList();
                        if (Session["PageUrl"] == null)
                        {
                            return Redirect("/Home");
                        }else if(Session["PageUrl"].ToString() == "" )
                            return Redirect("/Home");
                        else
                        {
                            return Redirect(
                                Session["PageUrl"].ToString());
                        }

                    }
                }
            }
            
            return View(objUser);
        }
        public ActionResult Logout(string ReturnUrl)
        {
            Session["UserID"] = "";
            Session["UserName"] = "";
            if (ReturnUrl == "" || ReturnUrl == null)
            {
                return View("Login");
            }
            else
            {
                return Redirect(
                    Session["PageUrl"].ToString());
            }
        }
        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        // GET: UserProfiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserProfile userProfile = db.UserProfiles.Find(id);
            if (userProfile == null)
            {
                return HttpNotFound();
            }
            return View(userProfile);
        }

        // GET: UserProfiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,UserName,Password,IsActive")] UserProfile userProfile)
        {
            if (ModelState.IsValid)
            {
                db.UserProfiles.Add(userProfile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userProfile);
        }

        // GET: UserProfiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserProfile userProfile = db.UserProfiles.Find(id);
            if (userProfile == null)
            {
                return HttpNotFound();
            }
            return View(userProfile);
        }

        // POST: UserProfiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,UserName,Password,IsActive")] UserProfile userProfile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userProfile);
        }

        // GET: UserProfiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserProfile userProfile = db.UserProfiles.Find(id);
            if (userProfile == null)
            {
                return HttpNotFound();
            }
            return View(userProfile);
        }

        // POST: UserProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserProfile userProfile = db.UserProfiles.Find(id);
            db.UserProfiles.Remove(userProfile);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}
