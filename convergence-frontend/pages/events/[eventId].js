import { Header, Image } from "semantic-ui-react"

import { formatDateTimeToFrCa } from "/lib/Utils"

export default function Event({ event }) {
    if (event == null) {
        return (
            <p>Erreur inconnue. Veuillez recommencer.</p>
        )
    }

    const eventDateTime = formatDateTimeToFrCa(event.dateTime)

    return (
        <>
            <Header as="h1">{event.title}</Header>
            <Image
                src="https://react.semantic-ui.com/images/wireframe/image.png"
                alt="Image représentant l'événement"
                size="large"
            />
            <Header as="h2">Détails</Header>
            <p>
                {event.description}
            </p>
            <Header as="h2">Lieu et date</Header>
            <p className="_event__datetime">{eventDateTime}</p>
            <p>
                {event.locationName}
                <br />
                {event.locationDetail}
            </p>
            <Header as="h2">Participants</Header>
            <p>
                Les participants seront affichés ici.
            </p>
        </>
    )
}

// Remplacer par getStaticProps et getStaticPaths
export async function getServerSideProps(context) {
    const eventId = context.params.eventId;
    const response = await fetch("http://localhost:3000/api/events/" + eventId);
    const event = await response.json();

    if (!response.ok || !event) {
        return {
            notFound: true
        }
    }

    return {
        props: {
            event
        }
    }
}
