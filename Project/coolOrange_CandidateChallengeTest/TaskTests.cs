using System.Linq;
using coolOrange_CandidateChallenge;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace coolOrange_CandidateChallengeTest
{
    [TestFixture]
    public class TaskTests
    {

        [Test]
        public void Task_SetPriority_GetPriority()
        {
            Task task = new Task("TestTask");
            task.SetPriority(Task.Priority.MAX_PRIORITY);

            Assert.AreEqual(Task.Priority.MAX_PRIORITY, task.GetPriority());
        }

        [Test]
        public void Task_SetComplexity_GetComplexity()
        {
            Task task = new Task("TestTask");
            task.SetComplexity(10);

            Assert.AreEqual(10, task.GetComplexity());
        }

        [Test]
        public void Task_CompareTo_NonTaskObject()
        {
            Task task = new Task("TestTask");
            object nonTaskObject = new object();

            Assert.Throws<ArgumentException>(() => task.CompareTo(nonTaskObject));
        }
    }
}
