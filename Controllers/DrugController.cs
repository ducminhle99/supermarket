using Microsoft.AspNetCore.Mvc;
using Drugstore.Services;
using Drugstore.Models;

namespace Drugstore.Controllers
{
    public class DrugController : Controller
    {
        private readonly IDrugService _drugService;

        public DrugController(IDrugService drugService)
        {
            _drugService = drugService;
        }
        public IActionResult Index()
        {
            var drugs = _drugService.GetDrugs();

            return View(drugs);
        }
        public IActionResult AddDrug()
        {
            return View("AddDrug");
        }
        public IActionResult EditDrug(int Id)
        {
            var drug = _drugService.GetDrugById(Id);

            return View(drug); 
        }
        public IActionResult Delete( int Id)
        {
            _drugService.DeleteDrug(Id);
            return Redirect("Index");
        }
        public IActionResult SaveDrug( Drug drug)
        {
            if(drug.Id == 0)
            {
                _drugService.AddNewDrug(drug);    
            }
            else {
                _drugService.EditDrug(drug);
            }
            return Redirect("Index");
        }  
    }
}