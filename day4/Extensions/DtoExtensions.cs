using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.Extensions
{
    internal static class DtoExtensions
    {
        internal static List<PersonDto> toConvertDto(this IEnumerable<Person> list)
        {
            return list.Select(x => new PersonDto() { fullname = $"{x.name}-{x.surname}", age = x.age }).ToList();
        }
    }
}
