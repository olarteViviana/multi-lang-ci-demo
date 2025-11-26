const { add } = require("../index");

if (add(2, 3) !== 5) {
  console.error("Test failed: expected 5");
  process.exit(1);
}
console.log("All tests passed");
