﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class Bai18
    {
        [TestMethod()]
        public void Method1()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();

                int ac = o.BodyCheck(-100, 54);
                int ex = -1;
                Assert.AreEqual(ex, ac);

            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Invalid input values";
                Assert.AreEqual(ex, ac);
            }
        }
        [TestMethod()]
        public void Method2()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();

                int ac = o.BodyCheck(155, 0);
                int ex = -1;
                Assert.AreEqual(ex, ac);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Invalid input values";
                Assert.AreEqual(ex, ac);
            }
        }
        [TestMethod()]
        public void Method3()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
                int ac = o.BodyCheck(170, 90);
                int ex = 1;
                Assert.AreEqual(ex, ac);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Invalid input values";
                Assert.AreEqual(ex, ac);
            }
        }

        [TestMethod()]
        public void Method4()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
                int ac = o.BodyCheck(170, 55);
                int ex = 0;
                Assert.AreEqual(ex, ac);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Invalid input values";
                Assert.AreEqual(ex, ac);
            }
        }

        [TestMethod()]
        public void Method5()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
                int ac = o.BodyCheck(162, 45);
                int ex = 2;
                Assert.AreEqual(ex, ac);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Invalid input values";
                Assert.AreEqual(ex, ac);
            }
        }

    }
}