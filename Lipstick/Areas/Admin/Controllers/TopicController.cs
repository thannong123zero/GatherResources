using Lipstick._Convergence.BusinessLogic.Helpers;
using Lipstick.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Areas.Admin.Controllers
{
    public class TopicController : Controller
    {
        private readonly TopicHelper _topicHelper;
        public TopicController(TopicHelper topicHelper)
        {
            _topicHelper = topicHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<TopicViewModel> data = await _topicHelper.GetTopics();
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
            await _topicHelper.CreateTopic(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            TopicViewModel data = await _topicHelper.GetTopicByID(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(TopicViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _topicHelper.UpdateTopic(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string ID)
        {
            return View();
        }
    }
}
