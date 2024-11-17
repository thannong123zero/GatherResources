using Lipstick._Convergence.BusinessLogic.IHelpers;
using Lipstick.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Areas.Admin.Controllers
{
    public class TopicController : Controller
    {
        private readonly ITopicHelper _topicHelper;
        public TopicController(ITopicHelper topicHelper)
        {
            _topicHelper = topicHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<TopicViewModel> data = await _topicHelper.GetAllAsync();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            TopicViewModel model = new TopicViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(TopicViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _topicHelper.CreateAsync(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(int ID)
        {
            TopicViewModel data = await _topicHelper.GetByIdAsync(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(TopicViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _topicHelper.UpdateAsync(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string ID)
        {
            return View();
        }
    }
}
