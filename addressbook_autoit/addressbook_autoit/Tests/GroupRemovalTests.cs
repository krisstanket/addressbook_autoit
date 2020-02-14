using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemove()
        {
            if (appManager.Groups.CheckGroupCount() <= 1)
            {
                var group = "newGroup";
                appManager.Groups.AddGroup(new GroupData { Name = group});
            }
            List<GroupData> oldGroups = appManager.Groups.GetGroupList();
            appManager.Groups.RemoveGroup(0);
            List<GroupData> newGroups = appManager.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
