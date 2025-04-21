============================
JavaScript Infinite Examples
============================

// Simple Infinite Loop
while(true) {
  console.log("This is an infinite loop");
}

// Event-Driven Infinite Algorithm
function infiniteAlgorithm() {
  setInterval(() => {
    console.log("Timer is running");
  }, 1000);
}
infiniteAlgorithm();

// Async Infinite Loop
async function infiniteAsync() {
  while (true) {
    await new Promise(resolve => setTimeout(resolve, 1000));
    console.log("Ran again after waiting");
  }
}
infiniteAsync();
