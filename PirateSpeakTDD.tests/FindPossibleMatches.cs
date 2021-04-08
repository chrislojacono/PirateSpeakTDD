using System;
using System.Collections.Generic;
using Xunit;

namespace PirateSpeakTDD.tests
{
    public class FindPossibleMatches
    {
        [Fact]
        public void the_word_matches_some_items_in_the_list()
        {
            //Arrange
            var possibleWords = new List<string>() { "sport", "parrot", "ports", "matey" };
            var jumbleWord = "ortsp";
            var expectedResult = new List<string>() { "sport", "ports" };
            var filter = new PirateSpeakFilter();
            //Act
            var actualResult = filter.Translator(jumbleWord, possibleWords);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
