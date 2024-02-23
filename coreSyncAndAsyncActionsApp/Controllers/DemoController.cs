using coreSyncAndAsyncActionsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace coreSyncAndAsyncActionsApp.Controllers
{
    public class DemoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Emp> data = await getEmpList();
            return View(data);
        }
        public Task<List<Emp>> getEmpList()
        {
            List<Emp> empobj = new List<Emp>
            {
                new Emp{ Id=1, Name="Yogesh"},
                new Emp{ Id=2, Name="Yogesh1"},
                new Emp{ Id=3, Name="Yogesh2"}
            };

            return Task.FromResult(empobj);
        }

        public IActionResult Index1()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            ContentManagement service = new ContentManagement();
            var content = service.GetContent();
            var count = service.GetCount();
            var name = service.GetName();

            watch.Stop();
            ViewBag.WatchMilliseconds = watch.ElapsedMilliseconds;
            return View();
        }
        public async Task<ActionResult> Index5()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            ContentManagement service = new ContentManagement();
            var contentTask = service.GetContentAsync();
            var countTask = service.GetCountAsync();
            var nameTask = service.GetNameAsync();

            var content = await contentTask;
            var count = await countTask;
            var name = await nameTask;
            watch.Stop();

            ViewBag.WatchMilliseconds = watch.ElapsedMilliseconds;
            return View();
        }
    }
}
