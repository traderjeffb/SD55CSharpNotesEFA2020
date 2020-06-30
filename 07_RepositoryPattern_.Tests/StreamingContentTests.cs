﻿using System;
using _07_RepositoryPattern_.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_.Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            StreamingContent content = new StreamingContent();
            content.Title = "Toy Story";

            string expected = "Toy Story";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow(GenreType.Thriller)]
        [DataRow(GenreType.Romance)]
        [DataRow(GenreType.Comedy)]
        public void SetGenre_ShouldSetCorrectGenre(GenreType typeOfGenre)
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            //Act
            content.TypeOfGenre = typeOfGenre;
            //Assert
            Assert.AreEqual(typeOfGenre, content.TypeOfGenre);
        }
    }
}
