using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    internal class Storage
    {
        const string resourceTypeInputStone = "камень";
        const string resourceTypeInputWood = "дерево";
        const string resourceTypeInputIron = "железо";
        const string resourceUndefined = "Тип ресурса не найден";
        List<Resource> resources;
        public Storage(Resource wood, Resource stone, Resource iron)
        {
            resources = new List<Resource>()
            {
                wood,
                stone,
                iron,
            };
        }
        
        public void ShowStorage()
        {
            foreach (var resource in resources)
            {
                Console.WriteLine($"Ресурс:{resource.resourceType} , Вес: {resource.count}");
            }
        }
        public void AddResource(string resourceTypeInput, int resourceValueInput)
        {
            switch (resourceTypeInput.ToLower())
            {
                case resourceTypeInputWood:
                    {
                        resources[0].count += resourceValueInput;
                        break;
                    }
                case resourceTypeInputStone:
                    {
                        resources[1].count += resourceValueInput;
                        break;
                    }
                
                case resourceTypeInputIron:
                    {
                        resources[2].count += resourceValueInput;
                        break;
                    }
                default:
                    {
                        Console.WriteLine(resourceUndefined);
                        break;
                    }
            }
        }
        private void ResourceCheck(ref int resources, int resourcesToSustract)
        {
            if ((resources - resourcesToSustract) > 0)
            {
                resources-= resourcesToSustract;
            }
            else
            {
                Console.WriteLine("Недостаточно ресурсов");
            }
        }
        public void SpendResource(string resourceTypeInput, int resourceValueInput)
        {
            switch (resourceTypeInput.ToLower())
            {
                case resourceTypeInputWood:
                    {
                        ResourceCheck(ref resources[0].count, resourceValueInput);
                        break;
                    }
                case resourceTypeInputStone:
                    {
                        ResourceCheck(ref resources[1].count, resourceValueInput);
                        break;
                    }

                case resourceTypeInputIron:
                    {
                        ResourceCheck(ref resources[2].count, resourceValueInput);
                        break;
                    }
                default:
                    {
                        Console.WriteLine(resourceUndefined);
                        break;
                    }
            }
        }
    }
}
