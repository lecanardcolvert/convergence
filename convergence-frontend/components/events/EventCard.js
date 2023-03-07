import Link from "next/link"
import { Card, Icon, Image } from 'semantic-ui-react'

import { formatDateTimeToFrCa, truncateString } from "/lib/Utils"

export default function EventCard({ event }) {
    if (event == null) {
        return (
            <p>Erreur lors de l'affichage.</p>
        )
    }

    const eventHref = "events/" + event.id
    const eventDateTime = formatDateTimeToFrCa(event.dateTime)
    const eventShortDescription = truncateString(event.description, 200)

    return (
        <Card
            as={Link}
            href={eventHref}
            fluid
            centered
            className="_event-card">
            <Image src='https://react.semantic-ui.com/images/wireframe/image.png'
                wrapped
                ui={false}
                alt="Image de l'événement" />

            <Card.Content>
                <Card.Header>
                    {event.title}
                </Card.Header>
                <Card.Description>
                    <span>{eventDateTime}, </span>
                    <span>{event.locationName}</span>
                </Card.Description>
            </Card.Content>

            <Card.Content>
                <Card.Description>
                    {eventShortDescription}
                </Card.Description>
            </Card.Content>

            <Card.Content>
                <Card.Description>
                    <Icon name='user' />
                    Certains participants seront affichés ici.
                </Card.Description>
            </Card.Content>
        </Card>
    )
}
