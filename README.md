1. When does Git perform a fast-forward and when is a merge commit created? 

2. What is the practical difference between merge and rebase? 

3. How was the conflict resolved in your repository? 



1.A fast-forward merge occurs when the target branch (the branch you are merging into) has not diverged from the source branch (the branch you are merging).
2.Merge combines branches while preserving the original history with a dedicated merge commit,while rebase rewrites project history by reapplying commits in a clean, linear sequence.
Merge is safer for public branches, whereas rebase is better for cleaning up local, unpushed feature branches.
3.We faced the choice between two possible variations of our code and we choose what we think should stay and remain in our code.
