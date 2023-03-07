export function formatDateTimeToFrCa(dateTime) {
    const options = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' }
    const localeDateString = new Date(dateTime).toLocaleDateString('fr-CA', options)
    const localeDateStringFirstUppercase = localeDateString.charAt(0).toUpperCase() + localeDateString.slice(1)
    return localeDateStringFirstUppercase
}

export function truncateString(str, num) {
    if (str.length <= num) {
        return str
    }

    return str.slice(0, num) + '...'
}
