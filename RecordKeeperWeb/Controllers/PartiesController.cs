using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecordKeeperBizObjects;

namespace RecordKeeperWeb.Controllers
{
    public class PartiesController : Controller
    {
        public ActionResult Index()
        {
            List<bizParty> lst = bizParty.GetAll();
            return View(lst);
        }
        [EnableCors("Policy1")]
        public ActionResult APIPartyList()
        {
            List<bizParty> lst = bizParty.GetAll();
            return Json(lst);
        }
        public ActionResult Details(string id)
        {
            bizParty p = bizParty.Get("PartyName", id);
            return View(p);
        }

        // GET: PartiesController1/Edit/5
        public ActionResult Edit(string id)
        {
            bizParty p;
            if (string.IsNullOrEmpty(id))
            {
                p = new();
            }
            else
            {
                p = bizParty.Get("PartyName", id);
            }    
            return View(p);
        }

        // POST: PartiesController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(bizParty partyobj)
        {
            try
            {
                partyobj.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PartiesController1/Delete/5
        public ActionResult Delete(string id)
        {
            bizParty p = bizParty.Get("PartyName", id);
            return View(p);
        }

        // POST: PartiesController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(bizParty party)
        {
            try
            {
                party.Delete();
                return RedirectToAction(nameof(Index));
            }
            catch (CPUFramework.CPUException ex)
            {
                party = bizParty.Get(party.PartyId);
                ViewBag.ErrorMessage = ex.FriendlyMessage;
                return View(party);
            }
        }
    }
}
