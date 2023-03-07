import { Grid } from "semantic-ui-react"

import EventCard from "./EventCard"

export default function EventGrid({ events }) {
    if (events == null) {
        return (
            <p>Aucun événement à afficher.</p>
        )
    }

    return (
        <Grid columns={3}>
            {events.map((event) => (
                <Grid.Column width={5}>
                    <EventCard event={event} key={event.Id} />
                </Grid.Column>
            ))}
        </Grid>
    )
}
