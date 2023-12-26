const colors = require('tailwindcss/colors');
module.exports = {
  content: [
      './**/*.razor',
      './wwwroot/index.html',
  ],
  theme: {
    extend: {
        typography: (theme) => ({
            DEFAULT: {
                css: {
                    color: theme('colors.neutral.200'), 
                },
            },
        }),
        colors: {
            primary: colors.emerald
        },
    },
  },
    plugins: [require('@tailwindcss/typography')],
}

