﻿using System;
using _08_Inheritance_Classes.Animals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Cat firstCat = new Cat();
            firstCat.Move();
            firstCat.MakeSounds();

            Liger oneLiger = new Liger();
            oneLiger.MakeSounds();
            oneLiger.Move();

            Animal oneAnimal = new Animal();
            oneAnimal.HasFur = false;
        }


    }
}
