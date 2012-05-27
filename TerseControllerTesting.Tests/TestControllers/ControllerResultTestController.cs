﻿using System.Web.Mvc;

namespace TerseControllerTesting.Tests.TestControllers
{
    class ControllerResultTestController : Controller
    {
        public const string RouteName = "RouteName";
        public const string RedirectUrl = "http://url/";
        public const string FileContentType = "application/contentType";
        public const string ViewName = "NamedView";
        public const string PartialName = "NamedPartial";
        public const int Code = 403;

        #region Empty, Null and Random Results
        public ActionResult EmptyResult()
        {
            return new EmptyResult();
        }

        public ActionResult Null()
        {
            return null;
        }

        public ActionResult RandomResult()
        {
            return new RandomResult();
        }

        public ActionResult RedirectToRandomResult()
        {
            return RedirectToAction("RandomResult");
        }
        #endregion

        #region Redirects
        public ActionResult RedirectToUrl()
        {
            return Redirect(RedirectUrl);
        }

        public ActionResult RedirectToRouteName()
        {
            return RedirectToRoute(RouteName);
        }

        public ActionResult RedirectToActionWithNoParameters()
        {
            return RedirectToAction("ActionWithNoParameters");
        }

        public ActionResult RedirectToActionWithOneParameter()
        {
            return RedirectToAction("ActionWithOneParameter");
        }

        public ActionResult RedirectToActionWithTwoParameters()
        {
            return RedirectToAction("ActionWithTwoParameters");
        }

        public ActionResult RedirectToActionWithThreeParameters()
        {
            return RedirectToAction("ActionWithThreeParameters");
        }

        public ActionResult RedirectToActionWithMoreThanThreeParameters()
        {
            return RedirectToAction("ActionWithMoreThanThreeParameters");
        }

        public ActionResult RedirectToAnotherController()
        {
            return RedirectToAction("SomeAction", "SomeOtherController");
        }

        #region Redirect Actions
        public ActionResult ActionWithNoParameters()
        {
            return new EmptyResult();
        }
        public ActionResult ActionWithOneParameter(int param1)
        {
            return new EmptyResult();
        }
        public ActionResult ActionWithTwoParameters(int param1, int param2)
        {
            return new EmptyResult();
        }
        public ActionResult ActionWithThreeParameters(int param1, int param2, int param3)
        {
            return new EmptyResult();
        }
        public ActionResult ActionWithMoreThanThreeParameters(int param1, int param2, int param3)
        {
            return new EmptyResult();
        }
        #endregion

        #endregion

        #region Views
        public ActionResult DefaultView()
        {
            return View();
        }

        public ActionResult DefaultPartial()
        {
            return PartialView();
        }

        public ActionResult EmptyFile()
        {
            var content = new byte[] {};
            return File(content, FileContentType);
        }

        public ActionResult NamedView()
        {
            return View(ViewName);
        }

        public ActionResult NamedPartial()
        {
            return PartialView(PartialName);
        }
        #endregion

        #region Http Status
        public ActionResult NotFound()
        {
            return HttpNotFound();
        }
        public ActionResult StatusCode()
        {
            return new HttpStatusCodeResult(Code);
        }
        #endregion

        #region JSON
        public ActionResult Json()
        {
            return Json("{data:true}");
        }
        #endregion
    }

    class SomeOtherController : Controller
    {
        public ActionResult SomeAction()
        {
            return new EmptyResult();
        }
    }

    class RandomResult : ActionResult
    {
        public override void ExecuteResult(ControllerContext context) {}
    }
}
