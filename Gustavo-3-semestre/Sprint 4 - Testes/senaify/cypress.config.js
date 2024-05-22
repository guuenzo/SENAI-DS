const { defineConfig } = require("cypress");

module.exports = defineConfig({
  e2e: {
    baseUrl: "http://localhost:8081",
    viewportHeight: 896,
    viewportWidth: 414,
    testIsolation: false,
    reactNativeHotRelode: true,
  },
});
