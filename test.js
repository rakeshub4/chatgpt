// write the function to add the two numbers and return the result
function add(a, b) {
  return a + b;
}   

// write the unit test for the function add 
// using the assert module
var assert = require('assert');
assert.equal(add(2, 3), 6);

// run the test using the command
// node test.js should print "All tests passed"
// if the test fails, it should print the error message
// and the stack trace
// node test.js should print
// AssertionError: 5 == 6

console.log("All tests passed");



// console.log("Addition of 2 and 3 is " + add(2, 3));
