/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./Pages/**/*.cshtml"],
  theme: {
    colors: {
      transparent: "transparent",
      currentColor: "currentColor",
      peach: {
        lighter: "#FDF3F0",
        light: "#FFAD9B",
        DEFAULT: "#E7816B",
        dark: "#E7816B",
      },
      grey: {
        light: "#F1F3F5",
        DEFAULT: "#333136",
        dark: "#333136",
      },
      black: "#1D1C1E",
      white: "#FFFFFF",
    },
    extend: {
      screens: {
        "3xl": "2000px",
      },
    },
  },
  plugins: [],
};
