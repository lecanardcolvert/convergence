import Head from "next/head"
import { Container } from 'semantic-ui-react'

import TopNavBar from "./TopNavBar"

export default function Layout({ children }) {
    return (
        <>
            <Head>
                <meta
                    name="description"
                    content="Convergence, là où les gens se rejoignent" />
                <meta
                    name="viewport"
                    content="width=device-width, initial-scale=1" />
                <title>Convergence : Là où les gens se rejoignent</title>
            </Head>
            <TopNavBar />
            <Container
                className="_layout__content"
                children={children} />
        </>
    )
}
