using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskTableMVC_app.Service;
using TaskTableMVC_app.ViewModels;
using TaskTableMVC_app.Models;

namespace TaskTableMVC_app.Controllers
{
    [Authorize]
    public class SubTaskController : Controller
    {
        SubTaskService subtaskService = SubTaskService.GetInstance;
        // GET: SubTask
        public ActionResult Index(int id)
        {
            SubTaskVM subTaskVM = new SubTaskVM();
            subTaskVM.SubTasks = subtaskService.GetSubTasks(id);
            return View(subTaskVM);
        }
        public ActionResult AddSubTask(int id, int userid, SubTaskVM tasksVM)
        {          
            return View(tasksVM);
        }

        [HttpPost]
        public ActionResult AddSubTask(AddSubTaskVM tasksVM,int id)
        {
            if (ModelState.IsValid)
            {
                subtaskService.AddSubTask(new Subtask
                {
                    TaskDetail = tasksVM.SubTask.TaskDetail,
                    DOI = DateTime.Now,                 
                    Status = tasksVM.SubTask.Status
                });
                return RedirectToAction("Index", new {});
            }
            return View(tasksVM);
        }

        public ActionResult UpdateSubTask(int id)
        {
            UpdateSubTask taskVM = new UpdateSubTask();
            taskVM.SubTask = subtaskService.GetSubTaskByID(id);           
            return View(taskVM);
        }

        [HttpPost]
        public ActionResult UpdateSubTask(UpdateSubTask taskVM, int id)
        {
            if (ModelState.IsValid)
            {
                subtaskService.UpdateSubTask(taskVM.SubTask);
                return RedirectToAction("Index", new { });
            }
            return View(taskVM);
        }

        public ActionResult DeleteSubTask(int id)
        {
            subtaskService.DeleteSubTask(id);
            return RedirectToAction("Index", new { });
        }
    }
}