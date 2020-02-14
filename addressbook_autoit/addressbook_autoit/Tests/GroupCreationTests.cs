using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void TestGroupCreate()
        {
            List<GroupData> oldGroups = appManager.Groups.GetGroupList();
            GroupData newGroup = new GroupData()
            { 
                Name = "test"
            };
            appManager.Groups.AddGroup(newGroup);
            List<GroupData> newGroups = appManager.Groups.GetGroupList();
            oldGroups.Add(newGroup);
            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
