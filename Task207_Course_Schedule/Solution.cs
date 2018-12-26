using System.Collections.Generic;

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

            var checkedDependencies = new bool[numCourses, numCourses];

            for (int course = 0; course < numCourses; course++)
            {
                var prerequisiteSet = new HashSet<int> { course };
                var courseToCheck = course;

                foreach (var dependency in dependencies[courseToCheck])
                {
                    if (!checkedDependencies[courseToCheck, dependency])
                    {
                        if (prerequisiteSet.Contains(dependency))
                        {
                            return false;
                        }
                        checkedDependencies[courseToCheck, dependency] = true;
                        prerequisiteSet.Add(dependency);
                        courseToCheck = dependency;
                    }
                }
            }

            return true;
        }
    }
}