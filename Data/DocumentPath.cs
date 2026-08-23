using System.Text;

namespace MinecraftLanguageModelLibrary.Data
{
    public class DocumentPath(string path)
    {
        #region Property
        /// <summary>
        /// 实际路径
        /// </summary>
        public string TargetPath { get; set; } = path;
        #endregion

        #region Method

        /// <summary>
        /// 获取路径的父级路径
        /// </summary>
        /// <returns></returns>
        public string GetParentPath()
        {
            string result = string.Empty;
            string path = TargetPath;
            int lastDoubleColonIndex = path.LastIndexOf("::");
            if (lastDoubleColonIndex > -1)
            {
                result = path[..lastDoubleColonIndex];
            }
            return result;
        }

        /// <summary>
        /// 获取路径的结束部分
        /// </summary>
        /// <returns></returns>
        public string GetTheEndPart()
        {
            string result = string.Empty;
            string path = TargetPath;

            int lastDoubleColonIndex = path.LastIndexOf("::");
            if (lastDoubleColonIndex > -1)
            {
                result = path[(lastDoubleColonIndex + 2)..];
            }
            return result;
        }

        /// <summary>
        /// 获取路径的起始部分
        /// </summary>
        /// <returns></returns>
        public string GetTheStartPart()
        {
            string result = string.Empty;
            string path = TargetPath;

            int lastDoubleColonIndex = path.IndexOf("::");
            if (lastDoubleColonIndex > -1)
            {
                result = path[..lastDoubleColonIndex];
            }
            return result;
        }

        /// <summary>
        /// 更改引用的目标
        /// </summary>
        /// <param name="newReference"></param>
        /// <returns></returns>
        public string ChangeReference(string newReference)
        {
            string result = string.Empty;
            string path = TargetPath;
            int lastDoubleColonIndex = path.LastIndexOf("::");
            if (lastDoubleColonIndex > -1)
            {
                result = path[..lastDoubleColonIndex] + "::" + newReference;
                TargetPath = new(result);
            }

            return result;
        } 
        #endregion
    }
}
