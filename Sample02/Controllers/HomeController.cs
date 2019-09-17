using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace 配置文件读取.Controllers
{
    public class HomeController : Controller
    {
        public readonly Book book;
        public HomeController(IOptions<Book> option)
        {
            book = option.Value;
        }
        public IActionResult Index()
        {
            return View(book);
        }
    }
}