# SpineBinaryConverter
Old Spine binary formats are unreadable with the current Spine animation program, and no backwards compatible version exists to edit Spine binary files before version 3.5. To fix this problem, this program takes old Spine skeleton binary files and converts them to the JSON equivelent so they can be parsed. 

## Notices
Currently, this repository uses spine-sharp version 3.4 from the [Spine runtimes](https://github.com/EsotericSoftware/spine-runtimes ) and therefore only parses version 3.4 binary files. It is possible to switch out the spine-sharp folder in this repository for a different version on the Spine-sharp github, but doing so will cause the program to fail to compile. More info in the Unfinished Work section under Version Swaping.



## Unfinished Work: ~85% Complete
  1. Color Support: color timelines are unparsed, so files that change color over time will be unable to do so.
  2. Event Support: files with interactable elements will not parse successfully and throw an error when trying to parse Events.
  3. Version Swaping: Small changes were made to the original spine-sharp project to make parsing binary files easier.  Currently the Deformation animations section has been changed to read pre-deformed vertices and offset.  
  
## Executables
  Latest Windows executable in releases or [here](https://github.com/PeterMoras/SpineBinaryConverter/releases/download/v0.85/SpineBinaryConverter.zip)
