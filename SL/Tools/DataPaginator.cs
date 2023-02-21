using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Tools
{
    public class DataPaginator<T>
    {
        private List<T> _data;

        public DataPaginator(List<T> data)
        {
            _data = data;
        }

        public List<T> GetPage(int page, int pageSize)
        {
            int startIndex = (page - 1) * pageSize;
            int endIndex = startIndex + pageSize;
            if (endIndex > _data.Count)
            {
                endIndex = _data.Count;
            }
            return _data.GetRange(startIndex, endIndex - startIndex);
        }
    }
}
