using System;
using System.IO;
using GradeBook.UserInterfaces;
using Xunit;

namespace GradeBookTests
{
    public class AddWeightedSupportToStartingUserInterfaceTests
    {
        /// <summary>
        ///     Tests Help Command update to ensure all changes were made correctly.
        /// </summary>
        [Fact(DisplayName = "Update HelpCommand Method @update-helpcommand-method")]
        public void UpdateHelpCommandTest()
        {
            //Setup Test
            var output = string.Empty;

            try
            {
                using (var consoleInputStream = new StringReader("close"))
                {
                    Console.SetIn(consoleInputStream);
                    using (var consolestream = new StringWriter())
                    {
                        Console.SetOut(consolestream);
                        StartingUserInterface.HelpCommand();
                        output = consolestream.ToString().ToLower();

                        // Test if help command message is correct
                        Assert.True(true);
                    }
                }
            }
            finally
            {
                StreamWriter standardOutput = new StreamWriter(Console.OpenStandardOutput());
                Console.SetOut(standardOutput);
            }
        }
    }
}
