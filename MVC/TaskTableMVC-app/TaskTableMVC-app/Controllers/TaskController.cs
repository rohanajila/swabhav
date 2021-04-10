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
    public class TaskController : Controller
    {
        // GET: Task
        TaskService taskService = TaskService.GetInstance;
        public ActionResult Index()
        {
            TaskVM TasksVM = new TaskVM();
            TasksVM.Tasks = taskService.GetTasks();            
            return View(TasksVM);
        }

        public ActionResult AddTask()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult AddTask(TasksVM tasksVM)
        {
            if (ModelState.IsValid)
            {
                taskService.AddTask(new Tasks
                {
                    TaskDetail = tasksVM.TaskDetails,
                    DOI = DateTime.Now,
                    Status = tasksVM.Status
                });
                return RedirectToAction("Index");
            }
            return View(tasksVM);
        }

        public ActionResult UpdateTask(int id)
        {
            UpdateTask taskVM = new UpdateTask();
            taskVM.Tasks = taskService.GetTaskByID(id);
            return View(taskVM);
        }

        [HttpPost]
        public ActionResult UpdateTask(UpdateTask taskVM)
        {
            if (ModelState.IsValid)
            {
                taskService.UpdateTask(taskVM.Tasks);
                return RedirectToAction("Index", new { });
            }
            return View(taskVM);
        }

        public ActionResult DeleteTask(int id)
        {
            taskService.DeleteTask(id);
            return RedirectToAction("Index", new { });
        }
    }
}