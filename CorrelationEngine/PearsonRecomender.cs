using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CorrelationEngine
{
    public class PearsonRecomender : IRecommender
    {
        public double GetCorrelation(int[] baseData, int[] otherData)
        {
            int sum_x = 0;
            int sum_y = 0;
            int sum_xy = 0;
            int sum_xx=0;
            int sum_yy = 0;
            if(baseData.Length> otherData.Length)
            {
                int i;
                int[] temp=new int[baseData.Length];
                for(i=0;i<otherData.Length;i++)
                {
                    temp[i]=otherData[i];
                }
                otherData=temp;
                for(;i<baseData.Length;i++)
                {
                    baseData[i]++;
                    otherData[i] = 1;
                }
                
            }
            int n=baseData.Length;  
            for(int i=0;i<baseData.Length;i++)
            {
                if (baseData[i]==0 || otherData[i]==0)
                {
                    baseData[i]++;
                    otherData[i]++;
                }
                //Console.WriteLine(baseData[i]+" " + otherData[i]);
                sum_x+=baseData[i];
                sum_y+=otherData[i];
                sum_xy += baseData[i] * otherData[i];
                sum_xx += baseData[i] * baseData[i];
                sum_yy += otherData[i] * otherData[i];
            }
            double corr = (double)(n * sum_xy - sum_x * sum_y) /
                     (Math.Sqrt((n * sum_xx -
                     sum_x * sum_x) * (n * sum_yy -
                     sum_y * sum_y)));
            return Math.Round(corr,6);
        }
    }
}
