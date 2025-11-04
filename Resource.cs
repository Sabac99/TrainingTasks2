using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    internal class Resource
    {
        public int count;
        public string resourceType;

        public Resource(string resourceType)
        {
            this.resourceType = resourceType;
            this.count = 0;
        }
        public Resource(int count,string resourceType)
        {
            this.resourceType = resourceType;
            this.count = count;
        }
    }
}

