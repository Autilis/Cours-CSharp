﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP.Models;
using TP5.Database;

namespace TP5.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Index()
        {
            List<Chat> chats = FakeDb.Instance.ListeChat;

            return View(chats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            Chat chats = FakeDb.Instance.ListeChat.Where(x => x.Id == id).FirstOrDefault();

            return View(chats);
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
