using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace AddressbookWhite
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            GroupData newGroup = new GroupData()
            {
                Name = "White"
            };
            app.Groups.Add(newGroup);
            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.Add(newGroup);
            oldGroups.Sort();
            newGroups.Sort();

            //Assert.AreEqual(oldGroups, newGroup);

        }
    }
}
