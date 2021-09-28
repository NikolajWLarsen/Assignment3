using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
	public static class Queries
	{


		public static IEnumerable<string> GetByCreator(this Lazy<IReadOnlyCollection<Wizard>> wizards, string creator)
		{
			var output =
			    from w in wizards.Value
			    where w.Creator == creator
			    select w.Name;

			return output;
		}

		public static IEnumerable<string> GetByCreatorE(this Lazy<IReadOnlyCollection<Wizard>> wizards, string creator)
		{
			var output = wizards.Value
				.Where(w => w.Creator == creator)
			    .Select(w => w.Name);

			return output;
		}

		public static bool IsSithLord(Wizard w) => w.Name.StartsWith("Darth");

		public static int? GetFirstWhere(this Lazy<IReadOnlyCollection<Wizard>> wizards, Predicate<string> predicate)
		{
			var output = (
			    from w in wizards.Value
			    where IsSithLord(w)
			    orderby w.Year
			    select w.Year
			).First();

			return output;
		}

		public static int? GetFirstWhereE(this Lazy<IReadOnlyCollection<Wizard>> wizards, Predicate<string> predicate)
		{
			var output = wizards.Value
				.Where(IsSithLord)
				.OrderBy(w => w.Year)
				.Select(w => w.Year)
				.First();
			
			return output;
		}

		public static IEnumerable<(string name, int? year)> GetByMedium(this Lazy<IReadOnlyCollection<Wizard>> wizards, string medium)
		{
            var output = (
			    from w in wizards.Value
			    where w.Medium == medium
			    select (w.Name, w.Year)
			).Distinct();

			return output;
		}

		public static IEnumerable<(string name, int? year)> GetByMediumE(this Lazy<IReadOnlyCollection<Wizard>> wizards, string medium)
		{
            var output = wizards.Value
				.Where(w => w.Medium == medium)
				.Select(w => (w.Name, w.Year))
				.Distinct();

			return output;
		}

		public static IEnumerable<string> GetSortedWizards(this Lazy<IReadOnlyCollection<Wizard>> wizards)
		{
            var output = 
			    from w in wizards.Value
                orderby w.Creator descending, w.Name
			    select w.Name;

			return output;
		}

		public static IEnumerable<string> GetSortedWizardsE(this Lazy<IReadOnlyCollection<Wizard>> wizards)
		{
            var output = wizards.Value
				.OrderByDescending(w => w.Creator).ThenBy(w => w.Name)
			    .Select(w => w.Name);
			
			return output;
		}
	}
}
