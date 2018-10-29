**TDD-As If You Mean It**

https://www.infoq.com/presentations/TDD-as-if-You-Meant-It 

* Run tests early.
  * No… much earlier than that. 
* Run tests often.
  * No… much more often than that. 
	
**In TDD design thinking goes on during refactoring** 
* “improving the design of existing code” 
* More specifically: “existing code that you know works”

**Use this process to write a tic-tac-toe game engine** 
* Add a test 
  * The simplest test you can think of 
* See it fail 
  * Not compiling counts as failing 
* Make all tests pass 
  * By writing the least code possible 
* Refactor 
  * In the shortest time possible 
* Repeat until done

**Be very strict about this:**
* Only add code to make a failing test pass 
* Only add brand-new code to test methods in a test class 
* Only create new non-test methods by “extract method” 
* Only create new classes as destinations for “move method” 

**Use version control**
* Check in on every green bar 
* Describe your current design thinking in the comment 
