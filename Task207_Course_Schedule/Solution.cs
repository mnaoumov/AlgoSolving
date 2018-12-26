using System.Collections.Generic;
using System.Linq;

namespace AlgoSolving.Task207_Course_Schedule
{
    public class Solution
    {
        public bool CanFinish(int numCourses, int[,] prerequisites)
        {
            var dependencies = new HashSet<int>[numCourses];

            for (int course = 0; course < numCourses; course++)
            {
                dependencies[course] = new HashSet<int>();
            }

            for (int i = 0; i < prerequisites.GetLength(0); i++)
            {
                dependencies[prerequisites[i, 0]].Add(prerequisites[i, 1]);
            }

            for (int course = 0; course < numCourses; course++)
            {
                var dependencyChain = new HashSet<int> { course };
                int courseToCheck = course;

                while (dependencies[courseToCheck].Any())
                {
                    int dependency = dependencies[courseToCheck].First();
                    if (dependencyChain.Contains(dependency))
                    {
                        return false;
                    }

                    dependencies[courseToCheck].Remove(dependency);
                    dependencyChain.Add(dependency);
                    courseToCheck = dependency;
                }
            }

            return true;
        }
    }
}