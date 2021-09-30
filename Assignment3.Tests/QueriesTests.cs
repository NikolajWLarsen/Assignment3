using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Assignment3.Tests
{
	public class QueriesTests
	{
		[Fact]
		public void Returns_Wizard_invented_by_Rowling()
		{
			// Arrange
			var wizards = Wizard.Wizards;

			// Act
			var actual = wizards.GetByCreator("Rowling");

			// Assert
			var expected = new[] { "Harry Potter", "Albus Dumbledore", "Voldemort" };
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Returns_Wizard_invented_by_Rowling_E()
		{
			// Arrange
			var wizards = Wizard.Wizards;

			// Act
			var actual = wizards.GetByCreatorE("Rowling");

			// Assert
			var expected = new[] { "Harry Potter", "Albus Dumbledore", "Voldemort" };
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Returns_Year_Where_Darth_something_was_introduced()
		{
			// Arrange
			var wizards = Wizard.Wizards;

			// Act
			var actual = wizards.GetFirstWhere(Queries.IsSithLord);

			// Assert
			var expected = 1977;
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Returns_Year_Where_Darth_something_was_introduced_E()
		{
			// Arrange
			var wizards = Wizard.Wizards;

			// Act
			var actual = wizards.GetFirstWhereE(Queries.IsSithLord);

			// Assert
			var expected = 1977;
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Returns_List_Of_tuple_nameAndYear_With_unique_wizards_from_HarryPotter()
		{
			// Arrange
			var wizards = Wizard.Wizards;

			// Act
			var actual = wizards.GetByMedium("Harry Potter");

			// Assert
			var expected = new (string, int?)[] {
				("Harry Potter", 1997),
				("Albus Dumbledore", 1997),
				("Voldemort", 2000)
			};
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Returns_List_Of_tuple_nameAndYear_With_unique_wizards_from_HarryPotter_E()
		{
			// Arrange
			var wizards = Wizard.Wizards;

			// Act
			var actual = wizards.GetByMediumE("Harry Potter");

			// Assert
			var expected = new (string, int?)[] {
				("Harry Potter", 1997),
				("Albus Dumbledore", 1997),
				("Voldemort", 2000)
			};
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Returns_Sorted_Wizards()
		{
			// Arrange
			var wizards = Wizard.Wizards;

			// Act
			var actual = wizards.GetSortedWizards();

			// Assert
			var expected = new[] {
            // Steven Soderbergh
                "Magic Mike",
            // Rowling
                "Albus Dumbledore",
				"Harry Potter",
				"Voldemort",
            // P.J. Hogan
                "Peter Pan",
            // L. Frank Baum
                "Oz",
            // Julian Jones
                "Merlin",
            // J.R.R. Tolkien
                "Gandalf",
				"Sauron",
            // George Lucas
                "Darth Vader"
			};
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Returns_Sorted_Wizards_E()
		{
			// Arrange
			var wizards = Wizard.Wizards;

			// Act
			var actual = wizards.GetSortedWizardsE();

			// Assert
			var expected = new[] {
            // Steven Soderbergh
                "Magic Mike",
            // Rowling
                "Albus Dumbledore",
				"Harry Potter",
				"Voldemort",
            // P.J. Hogan
                "Peter Pan",
            // L. Frank Baum
                "Oz",
            // Julian Jones
                "Merlin",
            // J.R.R. Tolkien
                "Gandalf",
				"Sauron",
            // George Lucas
                "Darth Vader"
			};
			Assert.Equal(expected, actual);
		}
	}
}
