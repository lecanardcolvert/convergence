import { Header } from "semantic-ui-react"

import EventGrid from "/components/events/EventGrid"

export default function Events({ events }) {
    console.log(events)

    return (
        <>
            <Header as="h1">Liste des événements</Header>
            <EventGrid events={events} />
        </>
    )
}

export async function getStaticProps(context) {
    const response = await fetch("http://localhost:3000/api/events");
    const events = await response.json();

    if (!response.ok) {
        return {
            notFound: true
        }
    }

    return {
        props: {
            events: events,
        },
    }
}
