using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.Extensions
{
    internal static class DtoExtensions
    {
        internal static List<PersonDto> toConvertDto(this IEnumerable<Person> list, Predicate<Person> predicate)
        {
            var personDtoList = new List<PersonDto>();
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    personDtoList.Add(new() { fullname = $"{item.name}-{item.surname}", age = item.age });
                }

            }
            return personDtoList;
        }
    }
}
