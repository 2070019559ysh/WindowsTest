using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLib
{
    public class Calculate
    {
        /// <summary>
        /// 获取整型数组中的最大值
        /// </summary>
        /// <param name="nums">整型数组</param>
        /// <returns>数组中的最大值</returns>
        public int GetMax(int[] nums)
        {
            if (nums == null) throw new ArgumentException("整型数组不能为空");
            int result = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > result)
                {
                    result = nums[i];
                }
            }
            return result;
        }

    }
}
