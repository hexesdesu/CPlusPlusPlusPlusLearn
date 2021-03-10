using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    /// <summary>
    /// 用于转换搜索类型与类名
    /// </summary>
    class SearchTypeEnum
    {
        enum SearchType {全部,模板,任务,事件,学生信息};
        enum ESClassName {ElasticSearch , TemplateElasticSearch , TaskGroupElasticSearch , EventsGroupElasticSearch , StudentInfoElasticSearch }
        /// <summary>
        /// 根据搜索类型获取枚举值
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private int GetSearchTypeId(string type)
        {
            SearchType searchType = (SearchType)Enum.Parse(typeof(SearchType), type);
            return (int)searchType;
        }
        /// <summary>
        /// 根据类名获取枚举值
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private int GetESClassNameId(string className)
        {
            ESClassName eSClassName = (ESClassName)Enum.Parse(typeof(ESClassName), className);
            return (int)eSClassName;
        }

        public string TransType2Class(string searchType)
        {
            SearchTypeEnum searchTypeEnum = new SearchTypeEnum();
            return Enum.GetName(typeof(ESClassName), (SearchType)Enum.Parse(typeof(SearchType), searchType));
        }
    }
}
