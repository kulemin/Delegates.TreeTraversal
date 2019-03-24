using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.TreeTraversal
{
    public delegate object Search(object tree);
    public static class Traversal
    {
        public static List<int> GetBinaryTreeValues(BinaryTree<int> tree)
        {
            var result = new List<int>();
            if (tree.Left != null)
            {
                GetBinaryTreeValues(tree.Left, result);
            }
            if (tree.Right != null)
            {
                GetBinaryTreeValues(tree.Right, result);
            }
            result.Add(tree.Value);
            return result;
        }

        public static List<int> GetBinaryTreeValues
            (BinaryTree<int> tree, List<int> result)
        {
            if (tree.Left != null)
            {
                GetBinaryTreeValues(tree.Left, result);
            }
            if (tree.Right != null)
            {
                GetBinaryTreeValues(tree.Right, result);
            }
            result.Add(tree.Value);
            return result;
        }

        public static List<Job> GetEndJobs(Job data)
        {
            var result = new List<Job>();
            if (data.Subjobs.Count() != 0) GetEndJobs(data.Subjobs, result);
            else result.Add(data);
            return result;
        }

        public static List<Job> GetEndJobs(List<Job> data, List<Job> result)
        {
            foreach (var job in data)
            {
                if (job.Subjobs.Count() != 0) GetEndJobs(job.Subjobs, result);
                else result.Add(job);
            }
            return result;
        }

        public static List<Product> GetProducts(ProductCategory data)
        {
            var result = new List<Product>();
            if (data.Categories.Count() != 0)
            {
                foreach (var category in data.Categories)
                    GetProducts(category, result);
            }
            foreach (var product in data.Products)
                result.Add(product);
            return result;
        }

        public static List<Product> GetProducts(ProductCategory data, List<Product> result)
        {
            if (data.Categories.Count() != 0)
            {
                foreach (var category in data.Categories)
                    GetProducts(category, result);
            }
            else foreach (var product in data.Products)
                    result.Add(product);
            return result;
        }
    }
}
