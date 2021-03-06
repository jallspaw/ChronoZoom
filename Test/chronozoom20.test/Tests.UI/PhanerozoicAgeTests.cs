﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PhanerozoicAgeTests : TestBase
    {
        public TestContext TestContext { get; set; }

        #region Initialize and Cleanup

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            
        }

        [TestInitialize]
        public void TestInitialize()
        {
            BrowserStateManager.RefreshState();
            HomePageHelper.OpenPage();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
            CreateScreenshotsIfTestFail(TestContext);
            NavigationHelper.NavigateToCosmos();
        }

        #endregion

        [TestMethod]
        public void Test_Eukaryotic_Cells_Description()
        {
            string description = ExhibitHelper.GetEukaryoticCellsDescription();
            StringAssert.Contains(description, "eukaryotic cells");
        }

        [TestMethod]
        public void Test_Navigate_To_Life()
        {
            TimelineHelper.OpenLifeTimeline();
            string actual = BreadcrumbsHelper.GetLastBreadcrumbs();
            Assert.AreEqual("Life", actual);
        }
    }
}