Command-line access

If you plan to make changes, use this command to check out the code as yourself using HTTPS:

# Project members authenticate over HTTPS to allow committing changes.
svn checkout https://design-patterns-research.googlecode.com/svn/trunk/ design-patterns-research --username: tanducspace@gmail.com --pass: xxxxx

When prompted, enter your generated googlecode.com password.
Use this command to anonymously check out the latest project source code:

# Non-members may check out a read-only working copy anonymously over HTTP.
svn checkout http://design-patterns-research.googlecode.com/svn/trunk/ design-patterns-research-read-only