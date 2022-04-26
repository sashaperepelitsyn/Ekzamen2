using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Application
    {
        private Application application;

        private List<TaskList> taskLists;

        /// <summary>
        /// Создает объект класса
        /// </summary>
        public Application()
        {
            TaskList TaskList = new TaskList("Входящие");
            taskLists = new List<TaskList>
            {
                TaskList
            };
        }

        /// <summary>
        /// Создает список задач с указанным именем и добавляет его в taskLists
        /// </summary>
        /// <param name="name"></param>
        public void CreateTaskList(string name)
        {
            TaskList TaskList = new TaskList(name);
            taskLists.Add(TaskList);
        }

        /// <summary>
        /// Возвращает имена списков задач
        /// </summary>
        /// <returns></returns>
        public List<string> GetTaskListNames()
        {
            List<string> listNames = new List<string>();

            foreach (TaskList item in taskLists)
            {
                listNames.Add(item.GetName());
            }

            return listNames;
        }
    }
}
