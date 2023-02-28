import Head from "next/head"
import TopNav from "./TopNav"

export default function Layout({children}) {
    return (
        <>
            <Head>
                <meta name="description" content="Convergence, là où les gens se rejoignent" />
                <meta name="viewport" content="width=device-width, initial-scale=1" />
                <title>Convergence, là où les gens se rejoignent</title>
            </Head>
            <TopNav />
            {children}
        </>
    )
}