using Microsoft.AspNetCore.Mvc;
using Core_MVC.Models;
namespace Core_MVC.Controllers
{
    public class ProductController : Controller
    {
        #region action 
        ////1 - can not be private
        ////2 - can not be static
        ////3 - can not be overload

        //// to call the action write in the url : product/showmessage
        //// not case sensitive
        //public string ShowMsg()
        //{
        //    return "Hello From First Action";
        //}

        //public ContentResult ShowMsg2()
        //{
        //    //declare
        //    ContentResult content = new ContentResult();
        //    //set data
        //    content.Content = "local message";
        //    //return
        //    return content;
        //}

        //public ViewResult ShowView()
        //{
        //    //declare
        //    ViewResult result = new ViewResult();
        //    //set
        //    result.ViewName = "view1"; 
        //    //return
        //    return result;
        //}

        ////to create view we go to Views folder and then add a new folder that 
        ////carries the name of controller but without word 'controller',
        ////then we enter this folder and create our file.cshtml

        ////type action can return
        //    // 1 - content "String"     ==> ContentResult
        //    // 2 - view "html"          ==> ViewResult
        //    // 3 - javascript           ==> JavascriptResult
        //    // 4 - json                 ==> JsonResult
        //    // 5 - notfound             ==> NotFoundResult
        //    // 6 - file                 ==> FileResult

        //public JsonResult ShowJson()
        //{
        //    //declare
        //    JsonResult result = new JsonResult(new { id = 1, name = "ahmed" });

        //    return result;

        //}

        ////Url: product/showmix/12     because the parameter has name 'id' and this is special case
        //// product/showmix?id=12     for any parameter
        //public IActionResult ShowMix(int id) //we used IActionResult interface as it s the common
        //{                                    //interface for all (ViewResult,ContentResult,JsonResult,....)
        //    if(id % 2 == 0)
        //    {
        //        ViewResult result = new ViewResult();
        //        result.ViewName = "View1";
        //        return result;

        //    }
        //    else
        //    {
        //        ContentResult result = new ContentResult();

        //        result.Content = $"Returned ID {id}";

        //        return result;

        //    }
        //}

        //public ContentResult EasyContent()
        //{
        //                                         //this function creates object from class 
        //    return Content("Hello Easy Code");   //ContentResult and insert the parameter 
        //                                         //in it, then returns that object
        //}

        //public ViewResult EasyView() {
        //    return View("View1");
        //}

        //public JsonResult EasyJson(){
        //    return Json(new { id = 123, name = "ahmed mamdouh" });
        //}
        #endregion

        public IActionResult Details(int id) {
            ProductSampleData product = new ProductSampleData();

            Product ProductModel = product.getProductByID(id);

            return View("ProductDetails",ProductModel);
        
        }

        public IActionResult AllDetails()
        {
            ProductSampleData data  = new ProductSampleData();
            return View("AllProducts", data.products);
        }




	}
}
