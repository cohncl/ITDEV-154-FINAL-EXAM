using System;
using System.Collections.Generic;
using System.Text;

namespace PowerList
{
    public class Details
    {
        // Task Id (Used for indexing)
        private int key;
        // Importance of task (A,B,C ...)
        private String priorityLevel;
        // What needs to be done
        private String taskName;
        // What day of the week the task needs to be done by
        private String day;

        public Details(int Id, String priority, String toDo, String doneBy) 
        {
            key = Id;
            priorityLevel = priority;
            taskName = toDo;
            day = doneBy;
        }

        public int getkey()
        {
            return key;
        }

        public String getpriorityLevel() 
        {
            return priorityLevel;
        }

        public String gettaskName()
        {
            return taskName;
        }

        public String getday()
        {
            return day;
        }

        public void setId(int id)
        {
            key = id;
        }

        public void setpriorityLevel(String priority) 
        {
            priorityLevel = priority;
        }

        public void settaskName(String toDo)
        {
            taskName = toDo;
        }

        public void setday(String doneBy)
        {
            day = doneBy;
        }

        public String toString() 
        {
            return key + " [" + priorityLevel + "] " + taskName + " " + day; 
        }
    }
}
