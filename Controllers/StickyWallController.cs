using Microsoft.AspNetCore.Mvc;
using ToDo_list.Models;

namespace ToDo_list.Controllers
{
    public class StickyWallController : Controller
    {
        public IActionResult Index()
        {
            // Всегда инициализируем модель и коллекцию Sections
            var model = new StickyWallViewModel
            {
                Sections = new List<StickySection>() // Важно инициализировать коллекцию!
            };

            // Заполняем данными
            model.Sections.Add(new StickySection
            {
                Title = "Social Media",
                Items = new List<string> 
                { 
                    "Plan social content",
                    "Build content calendar",
                    "Plan promotion and distribution"
                }
            });

            // Добавляем остальные секции...

            return View(model); // Не забываем передать модель в представление
        }
    }
}