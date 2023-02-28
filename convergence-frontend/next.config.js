/** @type {import('next').NextConfig} */
const nextConfig = {
    i18n: {
        locales: ["fr"],
        defaultLocale: "fr",
    },
}

module.exports = {
  async rewrites() {
    return [
      {
        source: "/api/:path*",
        destination: "http://localhost:5140/api/:path*",
      },
    ];
  },
};

module.exports = nextConfig;
