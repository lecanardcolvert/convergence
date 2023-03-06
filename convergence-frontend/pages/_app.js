import 'semantic-ui-css/semantic.min.css'
import Layout from '../components/layout/Layout'
import "../public/style.css"

export default function MyApp({Component, pageProps}) {
    return (
        <Layout>
            <Component {...pageProps} />
        </Layout>
    )
}