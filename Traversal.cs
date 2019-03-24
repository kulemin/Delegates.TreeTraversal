using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.TreeTraversal
{
    public static class Traversal
    {
        public static List<int> BinaryTreeResult = new List<int>();
        public static List<Job> JobResult = new List<Job>();
        public static List<Product> ProductResult = new List<Product>();

        public static List<int> GetBinaryTreeValues(BinaryTree<int> tree)
        {
            if (tree.Left != null)
            {
                GetBinaryTreeValues(tree.Left);
            }
            if (tree.Right != null)
            {
                GetBinaryTreeValues(tree.Right);
            }
            BinaryTreeResult.Add(tree.Value);
            return BinaryTreeResult;
        }

        public static List<Job> GetEndJobs(Job data)
        {
            if (data.Subjobs.Count() != 0) GetEndJobs(data.Subjobs);
            else JobResult.Add(data);
            return JobResult;
        }

        public static List<Job> GetEndJobs(List<Job> data)
        {
            foreach (var job in data)
            {
                if (job.Subjobs.Count() != 0) GetEndJobs(job.Subjobs);
                else JobResult.Add(job);
            }
            return JobResult;
        }

        public static List<Product> GetProducts(ProductCategory data)
        {
            if (data.Categories.Count() != 0)
            {
                foreach (var category in data.Categories) GetProducts(category);
            }
            foreach (var product in data.Products) ProductResult.Add(product);
            return ProductResult;
        }
    }
}
